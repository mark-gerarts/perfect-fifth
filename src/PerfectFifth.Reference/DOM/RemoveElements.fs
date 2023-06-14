module P5Reference.DOM.RemoveElements

open P5.Core
open P5.Color
open P5.Rendering
open P5.DOM

let setup p5 =
    createCanvas p5 100 100
    background p5 (Name "grey")
    let div = createDiv p5 "this is some text"
    let p = createP p5 "this is a paragraph"
    div.style "font-size" "16px"
    p.style "font-size" "16px"

let draw _ _ = ()

let onMousePressed p5 _ = removeElements p5

let run node =
    play node setup noUpdate draw [ OnMousePressed(Effect onMousePressed) ]
