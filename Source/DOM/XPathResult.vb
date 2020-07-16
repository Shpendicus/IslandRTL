﻿'''<Summary>The XPathResult interface represents the results generated by evaluating an XPath expression within the context of a given node.</Summary>
<DynamicInterface(GetType(EcmaScriptObject))>
Public Interface [XPathResult]
  '''<Summary>A boolean representing the value of the result if resultType is BOOLEAN_TYPE.</Summary>
  ReadOnly Property [booleanValue] As String
  '''<Summary>A number representing the value of the result if resultType is NUMBER_TYPE.</Summary>
  ReadOnly Property [numberValue] As String
  '''<Summary>A number code representing the type of the result, as defined by the type constants.</Summary>
  ReadOnly Property [resultType] As Dynamic
  '''<Summary>A Node representing the value of the single node result, which may be null.</Summary>
  ReadOnly Property [singleNodeValue] As Node
  '''<Summary>The number of nodes in the result snapshot.</Summary>
  ReadOnly Property [snapshotLength] As Integer
  '''<Summary>A string representing the value of the result if resultType is STRING_TYPE.</Summary>
  ReadOnly Property [stringValue] As String
End Interface