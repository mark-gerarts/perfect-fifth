module P5Reference.Events.TouchMoved2


open P5.Core

let draw _ _ = ()

let onTouchMoved _ event = console.log event

let subscriptions = [ OnTouchMoved(Effect onTouchMoved) ]

let run node =
    play node noSetup noUpdate draw subscriptions
