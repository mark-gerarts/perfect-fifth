module P5Reference.Events.KeyPressed2

open P5.Core

let draw _ _ = ()

let onKeyPressed _ _ = ()

// Any subscription can be wrapped in a `PreventDefault` to signal that the
// default event has to be prevented. This is the equivalent of returning
// `false` in a regular JavaScript p5js event handler.
//
// Alternative notation:
//
//   (PreventDefault (OnKeyPressed (Effect onKeyPressed)))
let subscriptions = [ Effect onKeyPressed |> OnKeyPressed |> PreventDefault ]

let run node =
    play node noSetup noUpdate draw subscriptions
