module P5Reference.Math.P5VectorFromAngle

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Data
open P5.Typography
open P5.Math
open P5.Events
open P5.Structure
open P5.Transform

let draw p5 _ =
    background p5 (Grayscale 200)

    // Create a variable, proportional to the mouseX,
    // varying from 0-360, to represent an angle in degrees.
    let myDegrees = map p5 (mouseX p5) 0 (width p5 |> float) 0 360

    // Display that variable in an onscreen text.
    // (Note the nfc() function to truncate additional decimal places,
    // and the "\xB0" character for the degree symbol.)
    let readout = sprintf "angle = %s\xB0" (nfcWithPrecision p5 myDegrees 1)
    noStroke p5
    fill p5 (Grayscale 0)
    text p5 readout 5 15

    // Create a p5.Vector using the fromAngle function,
    // and extract its x and y components.
    let v = P5Vector.fromAngleAndLength (radians p5 myDegrees) 30
    let vx = v.x
    let vy = v.y

    push p5
    translate p5 (width p5 / 2 |> float) (height p5 / 2 |> float)
    noFill p5
    stroke p5 (Grayscale 150)
    line p5 0 0 30 0
    stroke p5 (Grayscale 0)
    line p5 0 0 vx vy
    pop p5

let run node = animate node noSetup draw
