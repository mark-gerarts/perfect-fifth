module P5Reference.Structure.Push1

open P5.Core
open P5.Color
open P5.Shape
open P5.Structure

let draw p5 =
    circle p5 0 50 33 // Left circle

    push p5 // Start a new drawing state
    strokeWeight p5 10
    fill p5 (RGB(204, 153, 0))
    circle p5 33 50 33 // Left-middle circle

    push p5 // Start another new drawing state
    stroke p5 (RGB(0, 102, 153))
    circle p5 66 50 33 // Right-middle circle
    pop p5 // Restore previous state

    pop p5 // Restore original state

    circle p5 100 50 33 // Right circle

let run node = display node draw
