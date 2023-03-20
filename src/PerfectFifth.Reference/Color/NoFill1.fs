module P5Reference.Color.NoFill1

open P5.Core
open P5.Shape
open P5.Color
open P5.Rendering
open P5.Transform

let setup p5 = createCanvasWithMode p5 100 100 WebGL

let draw p5 t =
    background p5 (Grayscale 0)
    noFill p5
    stroke p5 (RGB(100, 100, 240))
    rotateX p5 (float t * 0.001)
    rotateY p5 (float t * 0.001)
    box p5 45 45 45

let run node = animate node setup draw
