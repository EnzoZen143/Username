using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
namespace SampleNameSpace
{
    public class SimpleScripts : MonoBehaviour
    {
        public string username;

        public string UserName
        {
            get { return username; }
            set { username = value; }
        }
    }
}
