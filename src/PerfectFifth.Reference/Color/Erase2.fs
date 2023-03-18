module P5Reference.Color.Erase2

open P5.Core
open P5.Typography
open P5.Color
open P5.Environment
open P5.Rendering
open P5.Shape
open P5.DOM
open P5.Transform

let setup p5 =
    smooth p5
    createCanvasWithMode p5 100 100 WebGL
    // Make a <p> element and put it behind the canvas
    let p = createP p5 "I am a dom element"
    p.center ()
    p.style "font-size" "20px"
    p.style "text-align" "center"
    p.style "z-index" "-9999"

let draw p5 t =
    background p5 (RGB(250, 250, 150))
    fill p5 (RGB(15, 195, 185))
    noStroke p5
    sphere p5 30
    erase p5
    rotateY p5 (float t * 0.002)
    translateZ p5 0 0 40
    torus p5 15 5
    noErase p5

    describe
        p5
        "60×60 centered teal sphere, yellow background. Torus rotating around sphere erases to reveal black text underneath."

let run node = animate node setup draw
