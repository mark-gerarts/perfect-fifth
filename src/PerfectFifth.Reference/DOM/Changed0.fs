module P5Reference.DOM.Changed0

open P5.Core
open P5.Color
open P5.Typography
open P5.DOM

let setup p5 =
    setTextAlign
        p5
        { horizontal = HorizontalAlign.Center
          vertical = Center }

    background p5 (Grayscale 200)
    let sel = createSelect p5
    sel.setPosition 10 10
    sel.option "pear"
    sel.option "kiwi"
    sel.option "grape"

    let mySelectEvent _ =
        let item = sel.getValue ()
        background p5 (Grayscale 200)
        text p5 (sprintf "It is a %s!" item) 50 50

    sel.changed mySelectEvent

let draw p5 _ = ()

let run node = animate node setup draw
