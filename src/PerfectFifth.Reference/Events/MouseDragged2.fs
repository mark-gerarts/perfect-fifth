module P5Reference.Events.MouseDragged2

open P5.Core

let draw _ _ = ()

let onMouseDragged _ event = console.log event

let subscriptions = [ OnMouseDragged(Effect onMouseDragged) ]

let run node =
    play node noSetup noUpdate draw subscriptions
