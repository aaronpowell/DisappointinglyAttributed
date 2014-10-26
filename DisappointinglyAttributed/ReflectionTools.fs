namespace DisappointinglyAttributed

module ReflectionTools =

    open System.Reflection

    let Disapproving obj =
        let isEmpty = obj.GetType().GetCustomAttributes<ಠ_ಠAttribute>(true)
                        |> Seq.isEmpty

        not isEmpty

    let AreTablesFlipped obj =
        let isEmpty = obj.GetType().GetCustomAttributes<``(╯°□°）╯︵┻━┻Attribute``>(true)
                        |> Seq.isEmpty

        not isEmpty