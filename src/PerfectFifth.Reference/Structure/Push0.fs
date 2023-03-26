module P5Reference.Structure.Push0

open P5.Core
open P5.Color
open P5.Shape
open P5.Transform
open P5.Structure

let draw p5 =
    circle p5 0 50 33 // Left circle

    push p5 // Start a new drawing state
    strokeWeight p5 10
    fill p5 (RGB(204, 153, 0))
    translate p5 50 0
    circle p5 0 50 33 // Middle circle
    pop p5 // Restore original state

    circle p5 100 50 33 // Right circle

let run node = display node draw
