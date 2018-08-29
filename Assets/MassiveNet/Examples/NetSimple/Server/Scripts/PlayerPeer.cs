using MassiveNet;
using UnityEngine;

public class PlayerPeer : MonoBehaviour {

    private NetView view;

	void Awake () {
	    view = GetComponent<NetView>();
	    view.OnReadInstantiateData += ReadInstantiateData;
	    view.OnReadSync += ReadSync;
	}

    void ReadSync(NetStream stream) {
        transform.position = stream.ReadVector3();
    }

    void ReadInstantiateData(NetStream stream) {
        transform.position = stream.ReadVector3();
    }
}
