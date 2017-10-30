using UnityEngine;
using System.Collections;

namespace Dylib.File
{
	public class WWWFile : File 
    {
		protected WWW _www;

        protected float m_progress = 0;

		public WWWFile(object data = null) : base(data){
			
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
		
		protected override void Preload(object data){
			if(data is string){
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
				OnError();
			}
            else
            {
				Parse();
				OnReady();
			}
		}

        //protected virtual object DoLoading() {
        //    string url = GetUrl();
        //    return _www = new WWW(url);
        //}

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

