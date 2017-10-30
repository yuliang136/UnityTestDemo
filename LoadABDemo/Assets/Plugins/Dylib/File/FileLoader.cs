using UnityEngine;
using System.Collections;
using System.Collections.Generic;


namespace Dylib.File{
	public class FileLoader : MonoBehaviour {

		#region Instance
		// --------------------------------------------------------------
		// Instance
		// --------------------------------------------------------------
		private static FileLoader s_Instance = null;
		public static FileLoader instance
		{
			get { return s_Instance; }
		}
		
		public static bool IsNull()
		{
			return (s_Instance == null);
		}
		#endregion

        public System.Reflection.Assembly assembly = null;

		protected Queue<IFile> _queueRequest = new Queue<IFile>();
		protected List<IFile> _loadingList = new List<IFile>();

        private HashSet<string> m_decompressList = new HashSet<string>();

		public const int COROUTINE_LOAD_LIMIT = 4;		//max load Num
		// Use this for initialization
		void Awake () {
			s_Instance = this;
            MyThread.DownLoadThreadPool.instance.setMaxNum(COROUTINE_LOAD_LIMIT);
            System.Net.ServicePointManager.DefaultConnectionLimit = 512;
		}

		// Update is called once per frame
		void Update () {

			if(_loadingList.Count > 0){
	//			foreach(IFile file in _loadingList){
	//				if(file.IsReady()) _loadingList.Remove(file);
	//			}
				if(_loadingList.Count > 0){
					for (int i = _loadingList.Count - 1; i >= 0; i--) {
                        if (_loadingList[i].IsDownLoadFile())
                        {
                            ((DownLoadFile)_loadingList[i]).Update(Time.deltaTime);
                        }
						if(_loadingList[i].IsReady() || _loadingList[i].IsFail()){
							_loadingList.RemoveAt(i);
						}
					}
				}
			}

			while (!IsQueueEmpty() && GetLoadingCount() < COROUTINE_LOAD_LIMIT)
			{
				SyncLoad(DequeueRequestFile());
			}
		}

		public bool IsQueueEmpty() {
			return _queueRequest.Count == 0;
		}

		public int GetLoadingCount(){
			return _loadingList.Count;
		}

		public IFile DequeueRequestFile() {
			return _queueRequest.Dequeue();
		}

		public void AsyncLoad(IFile file) {
			_queueRequest.Enqueue(file);

            if (GetLoadingCount() >= COROUTINE_LOAD_LIMIT)
            {
                Debug.Log("loading count is maximum, wait count = " + _queueRequest.Count);
            }
		}

		public void SyncLoad(IFile file) {
            if (_loadingList.IndexOf(file) < 0)
            {
                _loadingList.Add(file);
                if(!file.IsDownLoadFile())
                {
                    StartCoroutine(file.Loading());
                }
                else
                {
                    ((DownLoadFile)file).DownLoadBundle();
                }
            }
        }

        public void AddDecompressPath(string resPath)
        {
            if (!m_decompressList.Contains(resPath))
            {
                m_decompressList.Add(resPath);
            }
        }

        public bool IsDecompressRes(string resPath)
        {
            return m_decompressList.Contains(resPath);
        }

        public void ClearDecompressList()
        {
            m_decompressList.Clear();
        }

        public void Clear()
        {
            StopAllCoroutines();

            if (_loadingList.Count > 0)
            {
                _loadingList.Clear();
            }

            _queueRequest.Clear();
        }

	}
}
