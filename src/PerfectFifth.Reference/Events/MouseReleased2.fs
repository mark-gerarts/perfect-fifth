module P5Reference.Events.MouseReleased2

open P5.Core

let draw _ _ = ()

let onMouseReleased _ event = console.log event

let subscriptions = [ OnMouseReleased(Effect onMouseReleased) ]

let run node =
    play node noSetup noUpdate draw subscriptions
