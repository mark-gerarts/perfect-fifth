module P5Reference.Math.P5VectorFromAngles

open P5.Core
open P5.Color
open P5.Shape
open P5.Rendering
open P5.ThreeD
open P5.Math

let setup p5 =
    createWebGLCanvas p5 100 100
    fill p5 (Grayscale 255)
    noStroke p5

let draw p5 t =
    background p5 (Grayscale 255)

    let t' = float t / 1000.0

    // add three point lights
    P5Vector.fromAnglesAndLength (t' * 1.0) (t' * 1.3) 100
    |> pointLightFromVector p5 (Name "#f00")

    P5Vector.fromAnglesAndLength (t' * 1.1) (t' * 1.2) 100
    |> pointLightFromVector p5 (Name "#0f0")

    P5Vector.fromAnglesAndLength (t' * 1.2) (t' * 1.1) 100
    |> pointLightFromVector p5 (Name "#00f")

    sphere p5 35

let run node = animate node setup draw
