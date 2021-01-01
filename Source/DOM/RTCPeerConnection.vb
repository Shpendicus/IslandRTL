﻿'''<Summary>The RTCPeerConnection interface represents a WebRTC connection between the local computer and a remote peer. It provides methods to connect to a remote peer, maintain and monitor the connection, and close the connection once it's no longer needed.</Summary>
<DynamicInterface(GetType(EcmaScriptObject))>
Public Interface [RTCPeerConnection]
  '''<Summary>The read-only property RTCPeerConnection.currentLocalDescription returns an RTCSessionDescription object describing the local end of the connection as it was most recently successfully negotiated since the last time the  RTCPeerConnection finished negotiating and connecting to a remote peer. Also included is a list of any ICE candidates that may already have been generated by the ICE agent since the offer or answer represented by the description was first instantiated.</Summary>
  ReadOnly Property [currentLocalDescription] As String
  '''<Summary>The read-only property RTCPeerConnection.currentRemoteDescription returns an RTCSessionDescription object describing the remote end of the connection as it was most recently successfully negotiated since the last time the RTCPeerConnection finished negotiating and connecting to a remote peer. Also included is a list of any ICE candidates that may already have been generated by the ICE agent since the offer or answer represented by the description was first instantiated.</Summary>
  ReadOnly Property [currentRemoteDescription] As String
  '''<Summary>The read-only RTCPeerConnection property peerIdentity returns a JavaScript Promise that resolves to an RTCIdentityAssertion which contains a DOMString identifying the remote peer.</Summary>
  ReadOnly Property [peerIdentity] As String
  '''<Summary>The read-only property RTCPeerConnection.pendingLocalDescription returns an RTCSessionDescription object describing a pending configuration change for the local end of the connection. This does not describe the connection as it currently stands, but as it may exist in the near future. Use RTCPeerConnection.currentLocalDescription or RTCPeerConnection.localDescription to get the current state of the endpoint. For details on the difference, see Pending and current descriptions in WebRTC connectivity.</Summary>
  ReadOnly Property [pendingLocalDescription] As String
  '''<Summary>The read-only property RTCPeerConnection.pendingRemoteDescription returns an RTCSessionDescription object describing a pending configuration change for the remote end of the connection. This does not describe the connection as it currently stands, but as it may exist in the near future. Use RTCPeerConnection.currentRemoteDescription or RTCPeerConnection.remoteDescription to get the current session description for the remote endpoint. For details on the difference, see Pending and current descriptions in WebRTC connectivity.</Summary>
  ReadOnly Property [pendingRemoteDescription] As String
  '''<Summary>The read-only signalingState property on the RTCPeerConnection interface returns one of the string values specified by the RTCSignalingState enum; these values describe the state of the signaling process on the local end of the connection while connecting or reconnecting to another peer. See Signaling in Lifetime of a WebRTC session for more details about the signaling process.</Summary>
  ReadOnly Property [signalingState] As String
  '''<Summary>The RTCPeerConnection.onconnectionstatechange property specifies an EventHandler which is called to handle the connectionstatechange event when it occurs on an instance of RTCPeerConnection. This happens whenever the aggregate state of the connection changes.</Summary>
  Property [onconnectionstatechange] As EventListener
  '''<Summary>The RTCPeerConnection property onicecandidate property is an EventHandler which specifies a function to be called when the icecandidate event occurs on an RTCPeerConnection instance. This happens whenever the local ICE agent needs to deliver a message to the other peer through the signaling server.</Summary>
  Property [onicecandidate] As EventListener
  '''<Summary>The onsignalingstatechange event handler property of the RTCPeerConnection interface specifies a function to be called when the signalingstatechange event occurs on an RTCPeerConnection interface.</Summary>
  Property [onsignalingstatechange] As EventListener
  '''<Summary>The RTCPeerConnection method addTrack() adds a new media track to the set of tracks which will be transmitted to the other peer.</Summary>
  Function [addTrack]([partrack] As Dynamic, [parstream] As Dynamic) As Dynamic
  '''<Summary>The createOffer() method of the RTCPeerConnection interface initiates the creation of an SDP offer for the purpose of starting a new WebRTC connection to a remote peer.</Summary>
  Function [createOffer]([paroptions] As Dynamic) As Dynamic
  '''<Summary>The generateCertificate() method of the RTCPeerConnection interface creates and stores an X.509 certificate and corresponding private key then returns an RTCCertificate, providing access to it.</Summary>
  Function [generateCertificate]([parkeygenAlgorithm] As Dynamic) As Dynamic
  '''<Summary>The RTCPeerConnection method getSenders() returns an array of RTCRtpSender objects, each of which represents the RTP sender responsible for transmitting one track's data.</Summary>
  Function [getSenders]() As RTCRtpSender()
  '''<Summary>The RTCPeerConnection method getStats() returns a promise which resolves with data providing statistics about either the overall connection or about the specified MediaStreamTrack.</Summary>
  Function [getStats]([parselector] As Dynamic) As Dynamic
  '''<Summary>The RTCPeerConnection interface's getTransceivers() method returns a list of the RTCRtpTransceiver objects being used to send and receive data on the connection.</Summary>
  Function [getTransceivers]() As RTCRtpTransceiver()
  '''<Summary>The RTCPeerConnection.removeTrack() method tells the local end of the connection to stop sending media from the specified track, without actually removing the corresponding RTCRtpSender from the list of senders as reported by RTCPeerConnection.getSenders().</Summary>
  Function [removeTrack]([parsender] As Dynamic) As Dynamic
  '''<Summary>The WebRTC API's RTCPeerConnection interface offers the restartIce() method to allow a web application to easily request that ICE candidate gathering be redone on both ends of the connection.</Summary>
  Function [restartIce]() As Dynamic
  '''<Summary>The RTCPeerConnection method setLocalDescription() changes the local description associated with the connection. This description specifies the properties of the local end of the connection, including the media format.</Summary>
  Function [setLocalDescription]([parsessionDescription] As Dynamic) As String
  '''<Summary>The RTCPeerConnection method setRemoteDescription() sets the specified session description as the remote peer's current offer or answer. The description specifies the properties of the remote end of the connection, including the media format.</Summary>
  Function [setRemoteDescription]([parsessionDescription] As Dynamic) As String
End Interface