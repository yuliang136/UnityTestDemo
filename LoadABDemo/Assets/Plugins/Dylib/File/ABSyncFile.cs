using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Dylib.File
{
    public class ABSyncFile : ABFile
    {
        public ABSyncFile(object data = null, bool autoUnload = false) : base(data, autoUnload)
        {

        }

        public override void Load()
        {
            m_startTime = Time.realtimeSinceStartup;

            string url = GetUrl();
            if (Application.isEditor)
            {
                url = url.Replace("file:///", "");
            }
            else
            {
                url = url.Replace("file://", "");
            }
            _ab = AssetBundle.CreateFromFile(url);
            if (_ab == null)
            {
                Logger.Log("fail to load assetbundle " + url + " by CreateFromFile");
            }

            OnReady();
        }
    }
}
