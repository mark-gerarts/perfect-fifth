module P5Reference.Events.DoubleClicked2

open P5.Core

let draw _ _ = ()

let onDoubleClicked _ event = console.log event

let subscriptions = [ OnDoubleClicked(Effect onDoubleClicked) ]

let run node =
    play node noSetup noUpdate draw subscriptions
