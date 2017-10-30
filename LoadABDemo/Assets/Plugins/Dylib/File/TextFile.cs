using UnityEngine;
using System.Collections;


namespace Dylib.File{
	public class TextFile : WWWFile {

		public TextFile(object data = null) : base(data){
			
		}

		protected override void Parse() {
			_content = _www.text;
			//Debug.Log(_www.text);
		}

        protected override void DoLoadComplete()
        {
            base.DoLoadComplete();

            Clear();
        }

        protected override void OnError()
        {
            base.OnError();

            Clear();
        }

	}
}

