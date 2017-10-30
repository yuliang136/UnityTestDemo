using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using MyThread;
namespace Dylib.File
{
    public class DownLoadFile : File
    {
        protected HttpHelper _www = new HttpHelper();
        protected float m_progress = 0;
        public float time = 0f;
        public float beforeProgress;
        public const int TIME_OUT = 5;
        string md5 = string.Empty;
		int totleSize = 0;

        private int currSizeRecord = 0;
        private float checkTime = 0;

        public string MD5{
            get { return md5; }
            set { md5 = value; }
        }
        public DownLoadFile(object data = null)
			:base(data)
        {

            time = 0f;
        }

        public override void Clear()
        {
            if (_www != null)
            {
                _www.destory();
                _www = null;
            }

            base.Clear();
        }

        protected override void Preload(object data)
        {
            if (data is string)
            {
                _url = (string)data;
            }
        }
        //}

        protected override void OnError()
        {
            //Debug.LogError(_www.error);
            base.OnError();
        }

        public int GetKBDownloaded()
        {
			if (IsReady ()) {
				return (int)(totleSize / 1024);
			}
            return (int)(_www.CurrentSize / 1024);
        }
		public int getTotleSize()
		{
			return (int)_www.ToTleSize;
		}

        public byte[] getBytes()
        {
            return _www.Bytes;
        }
	

        public void DownLoadBundle()
        {
            _www.FilePath = _url;
            _www.init();
            currSizeRecord = 0;
            checkTime = 0;
            
            DownLoadThreadPool.instance.start(new WaitCallback(DownAsset), _www);
        }


        void DownAsset(System.Object h)
        {
            HttpHelper help = (HttpHelper)h;
            if (help != null)
                help.AsyDownLoad();
        }
		public override bool IsDownLoadFile()
        {
            return true;
        }
        
        public void Update(float deltaTime)
        {
            if (_www.isDone)
            {
                if (_www.ToTleSize != _www.CurrentSize)
                {
                    DownLoadBundle();
                }
                else
                {
					totleSize = (int)_www.ToTleSize;
                    OnReady();
                }
            }
            else
            {
                if (_www.CurrentSize != currSizeRecord)
                {
                    currSizeRecord = _www.CurrentSize;
                    checkTime = 0;
                }
                else
                {
                    checkTime += deltaTime;

                    if (checkTime > TIME_OUT)
                    {
                        Logger.Log("TIME_OUT :" + _www.FilePath);
                        DownLoadBundle();
                    }
                }
            }
        }

        
    }

}

