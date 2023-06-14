module P5Reference.DOM.Select

open P5.Core
open P5.Color
open P5.Rendering
open P5.DOM

let draw p5 =
    createCanvas p5 50 50
    background p5 (Grayscale 30)
    // move canvas down and right
    let canvas = select p5 "canvas"

    match canvas with
    | Some c -> c.setPosition 10 30
    | None -> failwith "Canvas not found"

let run node = display node draw
