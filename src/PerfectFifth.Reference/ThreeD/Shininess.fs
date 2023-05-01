module P5Reference.ThreeD.Shininess

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Rendering
open P5.ThreeD
open P5.Events
open P5.Transform

let setup p5 = createWebGLCanvas p5 100 100

let draw p5 _ =
    background p5 (Grayscale 0)
    noStroke p5
    let locX = mouseX p5 - (width p5 / 2 |> float)
    let locY = mouseY p5 - (height p5 / 2 |> float)
    ambientLight p5 (Grayscale 60)
    pointLight p5 (Grayscale 255) locX locY 50
    specularMaterial p5 (Grayscale 250)
    translate3D p5 -25 0 0
    shininess p5 1
    sphere p5 20
    translate3D p5 50 0 0
    shininess p5 20
    sphere p5 20

let run node = animate node setup draw
