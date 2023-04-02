module P5Reference.Events.MouseClicked2

open P5.Core

let draw _ _ = ()

let onMouseClicked _ event = console.log event

let subscriptions = [ OnMouseClicked(Effect onMouseClicked) ]

let run node =
    play node noSetup noUpdate draw subscriptions
