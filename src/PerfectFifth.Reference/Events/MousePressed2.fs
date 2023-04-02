module P5Reference.Events.MousePressed2

open P5.Core

let draw _ _ = ()

let onMousePressed _ event = console.log event

let subscriptions = [ OnMousePressed(Effect onMousePressed) ]

let run node =
    play node noSetup noUpdate draw subscriptions
