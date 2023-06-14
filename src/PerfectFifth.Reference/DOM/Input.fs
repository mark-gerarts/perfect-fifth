module P5Reference.DOM.Input

open P5.Core
open P5.Color
open P5.Rendering
open P5.DOM

let setup p5 =
    createCanvas p5 100 100
    background p5 (Name "grey")
    let inp = createInput p5
    inp.setPosition 0 0
    inp.setSize 100 10

    let myInputEvent _ =
        console.log (sprintf "You are typing %s" (inp.getValue ()))

    inp.input myInputEvent

let draw p5 _ = ()

let run node = animate node setup draw
