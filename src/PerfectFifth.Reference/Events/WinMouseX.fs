module P5Reference.Events.WinMouseX

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Rendering
open Browser
open P5.DOM
open P5.Events

let setup p5 =
    let canvas = createCanvasAndReturn p5 100 100
    let canvasEl = unbox<P5Element<'Unit>> canvas
    let body = document.querySelector "body"
    canvasEl.setParentFromNode body

    canvasEl

let draw p5 (canvas: P5Element<'Unit>) =
    background p5 (RGB(237, 34, 93))
    fill p5 (Grayscale 0)

    //move the canvas to the horizontal mouse position
    //relative to the window
    canvas.setPosition (winMouseX p5 + 1.0) (float (windowHeight p5) / 2.0)

    //the y of the square is relative to the canvas
    rect p5 20 (mouseY p5) 60 60

let run node = simulate node setup noUpdate draw
