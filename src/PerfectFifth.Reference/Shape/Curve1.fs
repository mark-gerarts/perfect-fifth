module P5Reference.Shape.Curve1

open P5.Core
open P5.Color
open P5.Shape

let draw p5 =
    // Define the curve points as anonymous records
    let p1 = {| x = 5; y = 26 |}
    let p2 = {| x = 73; y = 24 |}
    let p3 = {| x = 73; y = 61 |}
    let p4 = {| x = 15; y = 65 |}
    noFill p5
    stroke p5 (RGB(255, 102, 0))
    curve p5 p1.x p1.y p1.x p1.y p2.x p2.y p3.x p3.y
    stroke p5 (Grayscale 0)
    curve p5 p1.x p1.y p2.x p2.y p3.x p3.y p4.x p4.y
    stroke p5 (RGB(255, 102, 0))
    curve p5 p2.x p2.y p3.x p3.y p4.x p4.y p4.x p4.y

let run node = display node draw
