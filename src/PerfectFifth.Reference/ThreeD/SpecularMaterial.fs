module P5Reference.ThreeD.SpecularMaterial

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Rendering
open P5.ThreeD
open P5.Events

let setup p5 =
    createWebGLCanvas p5 100 100
    noStroke p5

let draw p5 _ =
    background p5 (Grayscale 0)
    ambientLight p5 (Grayscale 60)

    // add point light to showcase specular material
    let locX = mouseX p5 - (width p5 / 2 |> float)
    let locY = mouseY p5 - (height p5 / 2 |> float)
    pointLight p5 (Grayscale 255) locX locY 50

    specularMaterial p5 (Grayscale 250)
    shininess p5 50
    torusWithDetail p5 30 10 64 64

let run node = animate node setup draw
