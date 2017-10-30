using UnityEngine;
using System.Collections;

namespace Dylib.File
{
	public class WWWFile : File 
    {
        // WWW对象.
		protected WWW _www;

        // 进度显示.
        protected float m_progress = 0;

		public WWWFile(object data = null) : base(data)
        {
			// new对象之后
            // 把字符串传递给基类.
		}
		
		public override void Clear ()
        {
            if (_www != null)
            {
                _www.Dispose();
                _www = null;
            }

			base.Clear ();
		}
		
		protected override void Preload(object data)
        {
            // 基类的构造函数里调用Preload.
			if(data is string)
            {
                // 如果data是string.保存_url.
                // 这里只是保存值 没有实际去读取.
				_url = (string)data;
			}
		}

		public override IEnumerator Loading ()
        {
            string url = GetUrl();
            _www = new WWW(url);

            yield return _www;

            m_progress = 1;
			if(!string.IsNullOrEmpty(_www.error))
            {
                Logger.LogError(string.Format("url: {0} error: {1}", url, _www.error));

                // 发生错误时的处理.
				OnError();
			}
            else
            {
                // 资源成功加载后如何处理.
				Parse();
				OnReady();
			}
		}

		protected override void OnError() {
			//Debug.LogError(_www.error);
			base.OnError();
		}

        public int GetKBDownloaded()
        {
            return (int)(GetProgress() * _size);
        }

        public float GetProgress()
        {
            if (_www != null)
            {
                if (m_progress < 1)
                {
                    m_progress = _www.progress;
                }
            }

            return m_progress;
        }

        public WWW GetWWW()
        {
            return _www;
        }

	}
}

