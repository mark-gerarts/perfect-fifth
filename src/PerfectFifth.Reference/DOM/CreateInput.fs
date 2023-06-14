module P5Reference.DOM.CreateInput

open P5.Core
open P5.Color
open P5.DOM
open P5.Rendering

let draw p5 =
    createCanvas p5 100 100
    background p5 (Name "grey")
    let inp = createInput p5
    inp.setPosition 0 0
    inp.setSize 100 10

    inp.input (fun _ -> console.log ("You are typing " + (inp.getValue ())))

let run node = display node draw
