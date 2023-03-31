namespace P5

module Events =

    open Fable.Core
    open P5.Core

    type DeviceOrientation =
        | Landscape
        | Portrait
        | Unknown

    [<Emit("$0.deviceOrientation")>]
    let private deviceOrientation_ (p5: P5) : string = jsNative

    let deviceOrientation (p5: P5) : DeviceOrientation =
        match deviceOrientation_ p5 with
        | "landscape" -> Landscape
        | "portrait" -> Portrait
        | _ -> Unknown

    [<Emit("$0.accelerationX")>]
    let accelerationX (p5: P5) : float = jsNative

    [<Emit("$0.accelerationY")>]
    let accelerationY (p5: P5) : float = jsNative

    [<Emit("$0.accelerationZ")>]
    let accelerationZ (p5: P5) : float = jsNative

    [<Emit("$0.pAccelerationX")>]
    let pAccelerationX (p5: P5) : float = jsNative

    [<Emit("$0.pAccelerationY")>]
    let pAccelerationY (p5: P5) : float = jsNative

    [<Emit("$0.pAccelerationZ")>]
    let pAccelerationZ (p5: P5) : float = jsNative

    [<Emit("$0.rotationX")>]
    let rotationX (p5: P5) : float = jsNative

    [<Emit("$0.rotationY")>]
    let rotationY (p5: P5) : float = jsNative

    [<Emit("$0.rotationZ")>]
    let rotationZ (p5: P5) : float = jsNative

    [<Emit("$0.pRotationX")>]
    let pRotationX (p5: P5) : float = jsNative

    [<Emit("$0.pRotationY")>]
    let pRotationY (p5: P5) : float = jsNative

    [<Emit("$0.pRotationZ")>]
    let pRotationZ (p5: P5) : float = jsNative

    type TurnAxis =
        | X
        | Y
        | Z

    [<Emit("$0.turnAxis")>]
    let private turnAxis_ (p5: P5) : string = jsNative

    let turnAxis (p5: P5) : TurnAxis =
        match turnAxis_ p5 with
        | "X" -> X
        | "Y" -> Y
        | "Z" -> Z
        | _ -> failwith "Unexpected response from p5"

    [<Emit("$0.setMoveThreshold($1)")>]
    let setMoveThreshold (p5: P5) (value: float) : Unit = jsNative

    [<Emit("$0.setShakeThreshold($1)")>]
    let setShakeThreshold (p5: P5) (value: float) : Unit = jsNative

    [<Emit("$0.mouseX")>]
    let mouseX (p5: P5) : int = jsNative

    [<Emit("$0.mouseY")>]
    let mouseY (p5: P5) : int = jsNative
