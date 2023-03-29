module P5Reference.Rendering.SetAttributes2

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Rendering
open P5.ThreeD
open P5.Math
open P5.Transform

type Light =
    { c: string
      t: float
      p: float
      r: float }

let setup p5 =
    createWebGLCanvas p5 100 100
    noStroke p5
    fill p5 (Grayscale 255)

let lights =
    [ { c = "#f00"
        t = 1.12
        p = 1.91
        r = 0.2 }
      { c = "#0f0"
        t = 1.21
        p = 1.31
        r = 0.2 }
      { c = "#00f"
        t = 1.37
        p = 1.57
        r = 0.2 }
      { c = "#ff0"
        t = 1.12
        p = 1.91
        r = 0.7 }
      { c = "#0ff"
        t = 1.21
        p = 1.31
        r = 0.7 }
      { c = "#f0f"
        t = 1.37
        p = 1.57
        r = 0.7 } ]

let renderLight p5 t light =
    let width = width p5 |> float
    let v = P5Vector.fromAnglesAndLength (t * light.t) (t * light.p) (width * light.r)
    pointLightFromVector p5 (Name light.c) v

let draw p5 _ =
    let width = width p5 |> float
    let t = (millis p5 |> float) / 1000.0 + 1000.0
    background p5 (Grayscale 0)
    directionalLight p5 (Name "#222") 1 1 1

    lights |> List.iter (renderLight p5 t)

    specularMaterial p5 (Grayscale 255)
    sphere p5 (width * 0.1)

    rotateX p5 (t * 0.77)
    rotateY p5 (t * 0.83)
    rotateZ p5 (t * 0.91)
    torusWithDetail p5 (width * 0.3) (width * 0.07) 24 10


let onMousePressed p5 _ =
    setAttribute p5 "perPixelLighting" false
    noStroke p5
    fill p5 (Grayscale 255)

let onMouseReleased p5 _ =
    // To demonstrate an alternative
    setAttributes p5 {| perPixelLighting = true |}
    noStroke p5
    fill p5 (Grayscale 255)

let subscriptions =
    [ OnMousePressed(Effect onMousePressed)
      OnMouseReleased(Effect onMouseReleased) ]


let run node =
    play node setup noUpdate draw subscriptions
