module P5Reference.DOM.P5MediaElementSpeed

open P5.Core
open P5.Color
open P5.DOM
open P5.Rendering

let draw p5 =
    createCanvas p5 710 400

    let ele = createAudio p5 "assets/beat.mp3"
    ele.loop ()
    background p5 (Grayscale 200)

    let button2x = createButton p5 "2x speed"
    button2x.setPosition 100 68
    button2x.mousePressed (fun _ _ -> ele.setSpeed 2)

    let buttonHalf = createButton p5 "half speed"
    buttonHalf.setPosition 200 68
    buttonHalf.mousePressed (fun _ _ -> ele.setSpeed 0.5)

    let buttonRev = createButton p5 "reverse play"
    buttonRev.setPosition 300 68
    buttonRev.mousePressed (fun _ _ -> ele.setSpeed -1)

    let buttonStop = createButton p5 "STOP"
    buttonStop.setPosition 400 68
    buttonStop.mousePressed (fun _ _ -> ele.stop ())

    let buttonPlay = createButton p5 "PLAY!"
    buttonPlay.setPosition 500 68
    buttonPlay.mousePressed (fun _ _ -> ele.play ())

let run node = display node draw
