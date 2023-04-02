module P5Reference.Events.TouchEnded2

open P5.Core

let draw _ _ = ()

let onTouchEnded _ event = console.log event

let subscriptions = [ OnTouchEnded(Effect onTouchEnded) ]

let run node =
    play node noSetup noUpdate draw subscriptions
