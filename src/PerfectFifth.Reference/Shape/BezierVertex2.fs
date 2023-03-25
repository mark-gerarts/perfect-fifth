module P5Reference.Shape.BezierVertex2

open P5.Core
open P5.Color
open P5.Shape
open P5.Rendering
open P5.ThreeD

let setup p5 =
    createCanvasWithMode p5 100 100 WebGL
    setAttributes p5 "antialias" true

let draw p5 _ =
    orbitControl p5
    background p5 (Grayscale 50)
    strokeWeight p5 4
    stroke p5 (Grayscale 255)
    point p5 -25 30
    point p5 25 30
    point p5 25 -30
    point p5 -25 -30

    strokeWeight p5 1
    noFill p5

    beginShape p5
    vertex p5 -25 30
    bezierVertex p5 25 30 25 -30 -25 -30
    endShape p5

    beginShape p5
    vertex3D p5 -25 30 20
    bezierVertex3D p5 25 30 20 25 -30 20 -25 -30 20
    endShape p5

let run node = animate node setup draw
