using UnityEngine;
using System.Collections;
using System.Collections.Generic;


namespace Dylib.File
{
    public class FileLoader : MonoBehaviour
    {

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

        //public System.Reflection.Assembly assembly = null;

        // 资源加载的队列.
        protected Queue<IFile> _queueRequest = new Queue<IFile>();


        // 资源加载的List.
        protected List<IFile> _loadingList = new List<IFile>();

        private HashSet<string> m_decompressList = new HashSet<string>();

        public const int COROUTINE_LOAD_LIMIT = 4;		//max load Num
        // Use this for initialization
        void Awake()
        {
            // 在Awake里设置s_Instance.
            s_Instance = this;

            MyThread.DownLoadThreadPool.instance.setMaxNum(COROUTINE_LOAD_LIMIT);

            System.Net.ServicePointManager.DefaultConnectionLimit = 512;
        }

        // Update is called once per frame
        void Update()
        {
            // 这里为什么用两次相同条件判断.
            if (_loadingList.Count > 0)
            {

                if (_loadingList.Count > 0)
                {
                    for (int i = _loadingList.Count - 1; i >= 0; i--)
                    {
                        if (_loadingList[i].IsDownLoadFile())
                        {
                            ((DownLoadFile)_loadingList[i]).Update(Time.deltaTime);
                        }

                        // 判断是否已经Ready或者Fail时 把文件移除
                        if (_loadingList[i].IsReady() || _loadingList[i].IsFail())
                        {
                            _loadingList.RemoveAt(i);
                        }
                    }
                }
            }

            // 当_queueRequest.Count有值. 并且_loadingList.Count<COROUTINE_LOAD_LIMIT时.
            while (!IsQueueEmpty() && GetLoadingCount() < COROUTINE_LOAD_LIMIT)
            {
                // 同步加载？
                // 从_queueRequest.Dequeue()移除队列来同步加载.
                SyncLoad(DequeueRequestFile());
            }
        }

        public bool IsQueueEmpty()
        {
            return _queueRequest.Count == 0;
        }

        public int GetLoadingCount()
        {
            return _loadingList.Count;
        }

        public IFile DequeueRequestFile()
        {
            return _queueRequest.Dequeue();
        }

        /// <summary>
        /// 异步加载.
        /// </summary>
        /// <param name="file"></param>
        public void AsyncLoad(IFile file)
        {
            // 把资源放入队列.
            _queueRequest.Enqueue(file);

            // 正在Loading的文件如果超过COROUTINE_LOAD_LIMIT时 Debug出错误.
            int nLoadingCount = GetLoadingCount();
            if (nLoadingCount >= COROUTINE_LOAD_LIMIT)
            {
                Debug.Log("loading count is maximum, wait count = " + _queueRequest.Count);
            }
        }

        public void SyncLoad(IFile file)
        {
            // _loadingList里没有这个文件.
            if (_loadingList.IndexOf(file) < 0)
            {
                _loadingList.Add(file);
                if (!file.IsDownLoadFile())
                {
                    // 这个文件不是DownLoadFile
                    // 开始协程加载.
                    // 调用这个IFile文件自己的Loading.
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
