module P5Reference.Typography.Text2

open P5.Core
open P5.Color
open P5.Environment
open P5.Typography
open P5.Rendering
open P5.Transform

let preload p5 = loadFont p5 "assets/inconsolata.otf"

let setup p5 inconsolata =
    createWebGLCanvas p5 100 100
    setTextFont p5 inconsolata
    setTextSize p5 (width p5 / 3)

    setTextAlign
        p5
        { horizontal = HorizontalAlign.Center
          vertical = Center }

let draw p5 _ =
    background p5 (Grayscale 0)
    let time = millis p5 |> float
    rotateX p5 (time / 1000.0)
    rotateZ p5 (time / 1234.0)
    text p5 "p5.js" 0 0

let run node =
    simulateWithPreload node preload setup noUpdate draw
