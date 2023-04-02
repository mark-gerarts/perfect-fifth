module P5Reference.Events.TouchStarted2

open P5.Core

let draw _ _ = ()

let onTouchStarted _ event = console.log event

let subscriptions = [ OnTouchStarted(Effect onTouchStarted) ]

let run node =
    play node noSetup noUpdate draw subscriptions
