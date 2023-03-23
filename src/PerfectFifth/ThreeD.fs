namespace P5

module ThreeD =

    open Fable.Core
    open P5.Core

    /// TODO: sensitivity
    [<Emit("$0.orbitControl()")>]
    let orbitControl (p5: P5) : Unit = jsNative

    [<Emit("$0.normalMaterial()")>]
    let normalMaterial (p5: P5) : Unit = jsNative
