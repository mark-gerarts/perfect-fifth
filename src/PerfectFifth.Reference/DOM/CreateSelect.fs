module P5Reference.DOM.CreateSelect

open P5.Core
open P5.Color
open P5.Typography
open P5.DOM

let draw p5 =
    setTextAlign
        p5
        { horizontal = HorizontalAlign.Center
          vertical = Center }

    background p5 (Grayscale 200)
    let sel = createSelect p5
    sel.setPosition 10 10
    sel.option "oil"
    sel.option "milk"
    sel.option "bread"
    sel.disable "milk"

let run node = display node draw
