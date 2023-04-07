module P5Reference.Image.SaveCanvas1

open P5.Core
open P5.Color
open P5.Rendering
open P5.DOM
open P5.Image

let draw p5 =
    let c = createCanvasAndReturn p5 100 100 |> unbox<P5Element<obj>>
    background p5 (RGB(255, 0, 0))

    // all of the following are valid
    saveSpecificCanvasAs p5 c "myCanvas" "jpg"
    saveSpecificCanvas p5 c
    saveCanvasAs p5 "myCanvas" "png"
    saveCanvas p5

let run node = display node draw
