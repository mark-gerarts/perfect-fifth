module P5Reference.Math.AngleMode

open P5.Core
open P5.Math
open P5.Color
open P5.Environment
open P5.Events
open P5.Transform
open P5.Structure
open P5.Shape

let draw p5 _ =
    background p5 (Grayscale 204)

    let centerX = width p5 / 2 |> float
    let centerY = height p5 / 2 |> float

    setAngleMode p5 Degrees // Change the mode to DEGREES
    let a = Trig.atan2 p5 (mouseY p5 - centerY) (mouseX p5 - centerX)
    translate p5 centerX centerY
    push p5
    rotate p5 a
    rect p5 -20 -5 40 10 // Larger rectangle is rotating in degrees
    pop p5
    setAngleMode p5 Radians // Change the mode to RADIANS
    rotate p5 a // variable a stays the same
    rect p5 -40 -5 20 10 // Smaller rectangle is rotating in radians

let run node = animate node noSetup draw
