module P5Reference.DOM.P5ElementDragLeave

open P5.Core
open P5.Color
open P5.Environment
open P5.Rendering
open P5.Typography
open P5.DOM

let dragOverCallback p5 _ =
    background p5 (Grayscale 240)
    text p5 "Dragged off" (width p5 / 2 |> float) (height p5 / 2 |> float)

let setup p5 =
    let c = createCanvasAndReturn p5 100 100
    let c' = unbox<P5Element<Unit>> c
    background p5 (Grayscale 200)

    setTextAlign
        p5
        { horizontal = HorizontalAlign.Center
          vertical = Center }

    text p5 "Drag file" (width p5 / 2 |> float) (height p5 / 2 |> float)
    c'.dragLeave dragOverCallback

let draw _ _ = ()

let run node = animate node setup draw
