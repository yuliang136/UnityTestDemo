using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Dylib.File{
	public interface IFile {
		IEnumerator Loading();
		bool IsReady();
		bool IsFail();
		string GetUrl();
		void Clear();
		void LoadSync();
		void Load();
		object GetContent();
        void GetContentWhenReady(FileReadyDelegate callBack, FileReadyDelegate fail = null, object param1 = null, object param2 = null, object param3 = null);
        bool IsDownLoadFile();
	}
	
	public delegate void FileReadyDelegate(IFile file, object param1 = null, object param2 = null, object param3 = null);
	
	public class File : IFile {
		protected bool _ready = false;
		protected bool _fail = false;
		protected object _content = null;
		protected string _url = string.Empty;
		protected FileReadyDelegate _onReady = null;
		protected FileReadyDelegate _onFail = null;

        protected int _size = 0;

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

		public File(object data = null) {
			Preload(data);
			if(!string.IsNullOrEmpty(GetUrl())) {
				Load ();
			}
		}
		
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
		
		public void GetContentWhenReady(FileReadyDelegate callBack, FileReadyDelegate fail = null, object param1 = null, object param2 = null, object param3 = null) 
        {
            //_onReady += callBack;
            //if(fail!=null) _onFail += fail;
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
                FileDelData delData = new FileDelData(callBack, fail, param1, param2, param3);
                m_delData.Add(delData);
            }
		}
		
		public void LoadSync (){
			DoLoad(false);
		}
		
		public virtual void Load() {
			DoLoad();
		}
		
		protected void DoLoad(bool Async = true) {
			_ready = false;
			if(FileLoader.IsNull()){
				Logger.LogError("please init FileLoader before loading File.");
				return;
			}
			if(Async){
				FileLoader.instance.AsyncLoad(this);
			}else{
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


		protected virtual void OnError(){
			_fail = true;

            Logger.Log("can't load " + GetUrl());

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

		public virtual void OnReady() {
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
                    if (m_delData == null)
                    {
                        break;
                    }

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

        public virtual bool IsDownLoadFile()
        {
            return false;
        }
		
	}
}

