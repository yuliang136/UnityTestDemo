using UnityEngine;
using System;
using System.Collections;
using System.Reflection;
using System.IO;

namespace Dylib.File {
	public class ABFile : WWWFile 
    {
		protected AssetBundle _ab;
		protected bool _autoUnload;

        //protected UnityEngine.Object[] allAsset;

        protected float m_startTime = 0;

		public ABFile(object data = null, bool autoUnload = false) : base(data)
        {
			_autoUnload = autoUnload;

            m_startTime = Time.realtimeSinceStartup;
		}

		public override void Clear ()
        {
            if (_ab != null)
            {
                _ab.Unload(false);

                _ab = null;
            }

            //allAsset = null;
			base.Clear ();
		}
		
		protected override void Parse() 
        {
            try
            {
                _ab = _www.assetBundle;
            }
            catch (Exception ex)
            {
                Logger.LogError("www.assetbundle got exception. url=" + _url + " " + ex.Message);
            }
		}

		public T GetComponent<T>() where T : MonoBehaviour{
			if (_ab != null && _ab.mainAsset != null)
			{
				GameObject asset = _ab.mainAsset as GameObject;
				if (asset != null) return asset.GetComponent<T>();
			}
			return null;
		}

        public UnityEngine.Object GetMainAsset()
        {
            if (_ab != null)
            {
                return _ab.mainAsset;
            }

            return null;
        }

        //public UnityEngine.Object[] LoadAllAssets(){
        //    if (_ab != null && allAsset == null){
        //        #if UNITY_5_0
        //        allAsset = _ab.LoadAllAssets();
        //        #else
        //        allAsset = _ab.LoadAll();
        //        #endif
        //    }
        //    return allAsset;
        //}
		
		public UnityEngine.Object CloneObjectInAB(string obj){
			if(_ab != null){
				#if UNITY_5_0
				var sth = _ab.LoadAsset(obj);
				#else
				var sth = _ab.Load(obj);
				#endif
				if(sth != null){
					return UnityEngine.Object.Instantiate(sth);
				}
			}
			return null;
		}

        public UnityEngine.Object GetObjectInAB(string obj)
        {
            if (_ab != null)
            {
                    #if UNITY_5_0
				return _ab.LoadAsset(obj);
                    #else
                return _ab.Load(obj);
                    #endif
            }
            return null;
        }

        //protected override object DoLoading() {
        //    string url = GetUrl();
        //    return _www = new WWW(url);
        //    //return _www = WWW.LoadFromCacheOrDownload(url, 1);
        //}

		public override void OnReady ()
		{
            float nowTime = Time.realtimeSinceStartup;
            Logger.Log("load assetbundle " + _url + " use time " + (int)((nowTime - m_startTime) * 1000));

			base.OnReady ();

            if (_www != null)
            {
                _www.Dispose();
                _www = null;
            }

			if(_autoUnload){
				Clear();
			}
		}

		public bool Save(string path) {
			Byte[] bytes = _www.bytes;
			Stream sw = null;
			string dir = path.Substring(0, path.LastIndexOf("/"));
			bool suc = false;
			try{
				DirectoryInfo dirInfo = new DirectoryInfo(dir);
				if (!dirInfo.Exists) {
					dirInfo.Create();
				}
				if (System.IO.File.Exists(path)){
					System.IO.File.Delete(path);
				}
				FileInfo t = new FileInfo(path);
				sw = new FileStream(t.FullName, FileMode.OpenOrCreate, FileAccess.Write);
				sw.Write(bytes, 0, bytes.Length);
				suc = true;
			}catch (IOException e){
                Logger.LogError(e.Message);
			}finally{
				if (sw != null){
					sw.Close();
					sw.Dispose();
				}
			}
			return suc;
		}

        public void UnloadBundle(bool unloadAllLoadedObjects)
        {
            if (_ab != null)
            {
                _ab.Unload(unloadAllLoadedObjects);
                _ab = null;
            }

            if (_www != null)
            {
                _www.Dispose();
                _www = null;
            }
        }

        protected override void DoLoadComplete()
        {
            base.DoLoadComplete();
        }

        public AssetBundle GetAB()
        {
            return _ab;
        }
	}
}


