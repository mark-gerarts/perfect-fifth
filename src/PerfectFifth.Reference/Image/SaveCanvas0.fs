module P5Reference.Image.SaveCanvas0

open P5.Core
open P5.Color
open P5.Rendering
open P5.Image
open P5.DOM

let draw p5 =
    let c = createCanvasAndReturn p5 100 100 |> unbox<P5Element<obj>>
    background p5 (RGB(255, 0, 0))
    saveSpecificCanvasAs p5 c "myCanvas" "jpg"

let run node = display node draw
