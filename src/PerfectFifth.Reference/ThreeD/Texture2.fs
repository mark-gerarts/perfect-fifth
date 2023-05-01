module P5Reference.ThreeD.Texture2

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.DOM
open P5.Rendering
open P5.ThreeD

let preload p5 =
    let vid = createVideo p5 "assets/fingers.mov"
    vid.hide ()
    vid

let setup p5 vid =
    console.log vid
    createWebGLCanvas p5 100 100
    vid

let draw p5 (vid: P5MediaElement) =
    background p5 (Grayscale 0)
    texture p5 vid
    square p5 -40 -40 80

let onMousePressed _ _ (vid: P5MediaElement) =
    vid.loop ()
    vid

let subscriptions = [ OnMousePressed(Update onMousePressed) ]

let run node =
    playWithPreload node preload setup noUpdate draw subscriptions
