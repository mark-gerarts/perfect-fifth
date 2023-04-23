module P5Reference.Math.Constrain

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Events
open P5.Math

let draw p5 _ =
    background p5 (Grayscale 200)

    let leftWall = 25
    let rightWall = 75

    // xm is just the mouseX, while
    // xc is the mouseX, but constrained
    // between the leftWall and rightWall!
    let xm = mouseX p5
    let xc = constrain p5 xm leftWall rightWall

    // Draw the walls.
    stroke p5 (Grayscale 150)
    line p5 leftWall 0 leftWall (height p5 |> float)
    line p5 rightWall 0 rightWall (height p5 |> float)

    // Draw xm and xc as circles.
    noStroke p5
    fill p5 (Grayscale 150)
    circle p5 xm 33 9 // Not Constrained
    fill p5 (Grayscale 0)
    circle p5 xc 66 9 // Constrained

let run node = animate node noSetup draw
