using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Dylib.File{

    // 接口,不实现具体代码.
	public interface IFile {

        // 迭代器.
		IEnumerator Loading();

        // 是否准备完成.
		bool IsReady();

        // 是否失败.
		bool IsFail();

        // 获得Url地址.
		string GetUrl();

        // 如何清理？
		void Clear();

        // 同步加载？
		void LoadSync();

        // Load是什么意思.
		void Load();

        // 获得资源.
		object GetContent();

        // 当准备好时获得Content.
        void GetContentWhenReady(FileReadyDelegate callBack, FileReadyDelegate fail = null, object param1 = null, object param2 = null, object param3 = null);
        
        // 判断是否是DownLoad资源.
        bool IsDownLoadFile();
	}
	
    /// <summary>
    /// 自定义委托
    /// </summary>
    /// <param name="file">满足IFile接口的file对象.</param>
    /// <param name="param1"></param>
    /// <param name="param2"></param>
    /// <param name="param3"></param>
	public delegate void FileReadyDelegate(IFile file, object param1 = null, object param2 = null, object param3 = null);
	
	public class File : IFile {
		protected bool _ready = false;                      // 标识文件的加载状态. 是否完成
        protected bool _fail = false;                       // 标识文件的加载状态. 是否有错误.
		protected object _content = null;
		protected string _url = string.Empty;
		protected FileReadyDelegate _onReady = null;        // 定义委托对象.
		protected FileReadyDelegate _onFail = null;         // 定义委托对象.
                
        protected int _size = 0;                            // 这个size有什么用.

        private List<FileDelData> m_delData = new List<FileDelData>();

        private class FileDelData
        {
            public FileReadyDelegate delFinish;
            public FileReadyDelegate delFail;
            public object param1;
            public object param2;
            public object param3;

            public FileDelData()
            {

            }

            public FileDelData(FileReadyDelegate delFinish, FileReadyDelegate delFail, object param1, object param2, object param3)
            {
                this.delFinish = delFinish;
                this.delFail = delFail;
                this.param1 = param1;
                this.param2 = param2;
                this.param3 = param3;
            }
        }

        /// <summary>
        /// 构造函数.
        /// </summary>
        /// <param name="data"></param>
		public File(object data = null) 
        {
            // 在构造函数里 开始Preload
			Preload(data);

            // 这里写得有问题.
            // 在子类里才判断为string
			if(!string.IsNullOrEmpty(GetUrl())) 
            {
                // 子类是否重载了Load
				Load();
			}
		}
		
        /// <summary>
        /// 由子类来具体实现.
        /// </summary>
        /// <param name="data"></param>
		protected virtual void Preload(object data) {
			
		}
		
		public virtual void Clear()
        {
            if (m_delData != null)
            {
                m_delData.Clear();
                m_delData = null;
            }
		}
		
		public virtual string GetUrl() {
			return _url;
		}
		
		public object GetContent() {
			return _content;
		}

        public virtual void SetSize(int size)
        {
            _size = size;
        }

        public virtual int GetSize()
        {
            return _size;
        }
		
        /// <summary>
        /// 设置回调.
        /// </summary>
        /// <param name="callBack"></param>
        /// <param name="fail"></param>
        /// <param name="param1"></param>
        /// <param name="param2"></param>
        /// <param name="param3"></param>
		public void GetContentWhenReady(FileReadyDelegate callBack, FileReadyDelegate fail = null, object param1 = null, object param2 = null, object param3 = null) 
        {
            // param1 param2 param3参数由调用处传入 处理完毕后传出？

            // New的时候就已经在加载了. New和GetContentWhenReady可以分离放置.
			if(IsReady())
            {
				if (callBack != null)
                {
                    callBack.Invoke(this, param1, param2, param3);
                }
			}
            else if (IsFail())
            {
                if (fail != null)
                {
                    fail.Invoke(this, param1, param2, param3);
                }
            }
            else
            {
                // 没有Ready和Fail时 说明正在加载 设置回调数据来记录 之后调用.
                // 如果New之后马上调用GetContentWhenReady时
                // 应该会记录一份数据.
                FileDelData delData = new FileDelData(callBack, fail, param1, param2, param3);
                m_delData.Add(delData);
            }
		}
		
		public void LoadSync ()
        {
			DoLoad(false);
		}
		
		public virtual void Load() 
        {
			DoLoad();
		}
		
        /// <summary>
        /// Async默认为打开状态.
        /// </summary>
        /// <param name="Async">是否开启异步加载.</param>
		protected void DoLoad(bool Async = true) 
        {
            // 重置_ready状态?
			_ready = false;
			if(FileLoader.IsNull())
            {
				Logger.LogError("please init FileLoader before loading File.");
				return;
			}

            // 判断是否是异步加载 默认使用异步加载.
			if(Async)
            {
                // 把File对象传递给FileLoader Mono单例.
				FileLoader.instance.AsyncLoad(this);
			}
            else
            {
				FileLoader.instance.SyncLoad(this);
			}
		}
		
		public bool IsReady() {
			return _ready;
		}

		public bool IsFail() {
			return _fail;
		}
		
		public virtual IEnumerator Loading() {
			yield return null;
			Parse();
			OnReady();
		}


		protected virtual void OnError()
        {
			_fail = true;

            Logger.Log("can't load " + GetUrl());

            // 这个m_delData有什么作用？
            if (m_delData != null)
            {
                int length = m_delData.Count;
                for (int i = 0; i < length; i++)
                {
                    if (m_delData == null)
                    {
                        break;
                    }

                    if (m_delData[i] != null)
                    {
                        if (m_delData[i].delFail != null)
                        {
                            m_delData[i].delFail.Invoke(this, m_delData[i].param1, m_delData[i].param2, m_delData[i].param3);
                        }
                    }
                }
            }

            if (m_delData != null)
            {
                m_delData.Clear();
            }

			if(_onFail != null){
				//_onFail.Invoke(this);
				FileReadyDelegate tmp = _onFail;
				_onFail = null;
				tmp.Invoke(this);
			}
			_onReady = null;
		}

		protected virtual void Parse() {
			
		}

        /// <summary>
        /// 资源加载完毕后 设置_ready为true.
        /// 调用DoLoadComplete
        /// </summary>
		public virtual void OnReady() 
        {
			_ready = true;
			DoLoadComplete();
		}
		
		protected virtual void DoLoadComplete() 
        {
            if (m_delData != null)
            {
                int length = m_delData.Count;
                for (int i = 0; i < length; i++)
                {
                    // 之前已经做过判断 为什么这里还有可能为null?
                    if (m_delData == null)
                    {
                        break;
                    }

                    // del的意思应该是delegate.
                    if (m_delData[i] != null)
                    {
                        if (m_delData[i].delFinish != null)
                        {
                            m_delData[i].delFinish.Invoke(this, m_delData[i].param1, m_delData[i].param2, m_delData[i].param3);
                        }
                    }
                }
            }

            if (m_delData != null)
            {
                m_delData.Clear();
            }

			if(_onReady != null){
				//_onReady.Invoke(this);
				FileReadyDelegate tmp = _onReady;
				_onReady = null;
				tmp.Invoke(this);
			}
			_onFail = null;
		}

        /// <summary>
        /// 判断文件是否是DownLoadFile?
        /// </summary>
        /// <returns></returns>
        public virtual bool IsDownLoadFile()
        {
            return false;
        }
		
	}
}

