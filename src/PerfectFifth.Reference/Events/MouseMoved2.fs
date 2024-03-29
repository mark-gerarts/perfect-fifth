module P5Reference.Events.MouseMoved2

open P5.Core

let draw _ _ = ()

let onMouseMoved _ event = console.log event

let subscriptions = [ OnMouseMoved(Effect onMouseMoved) ]

let run node =
    play node noSetup noUpdate draw subscriptions
