Imports System
Module alquiler_de_apartamentos
    Sub Main(args As String())
        Dim ids(9) As Integer
        Dim inquilinos(9) As String
        Dim apartamentos(9) As String
        Dim tiposApartamento(9) As String
        Dim fechasInicio(9) As String
        Dim fechasFinalizacion(9) As String
        Dim meses(9) As Integer
        Dim preciosMensuales(9) As Double
        Dim totales(9) As Double
        Dim estados(9) As String
        Dim observaciones(9) As String
        Dim cantidad As Integer = 0
        Dim opcion As Integer
        '---------------------------------------------'
        '--|menu_principal_alquiler_de_apartamentos|--'
        '---------------------------------------------'
        Do
            Console.WriteLine("menu principal alquiler de apartamentos")
            Console.WriteLine("1) Registrar alquiler")
            Console.WriteLine("2) Editar alquiler")
            Console.WriteLine("3) Listar alquileres")
            Console.WriteLine("4) Buscar alquiler")
            Console.WriteLine("5) Eliminar alquiler")
            Console.WriteLine("6) Mostrar resumen")
            Console.WriteLine("7) Salir")
            Console.Write("Seleccione una opcion: ")
            opcion = Convert.ToInt32(Console.ReadLine())
            Select Case opcion
                '------------------------'
                '--|registrar_alquiler|--'
                '------------------------'
                Case 1
                    If cantidad >= ids.Length Then
                        Console.WriteLine("No hay espacio para registrar mas alquileres.")
                    Else
                        ids(cantidad) = cantidad + 1
                        Console.Write("Inquilino: ")
                        inquilinos(cantidad) = Console.ReadLine()
                        Console.Write("Apartamento: ")
                        apartamentos(cantidad) = Console.ReadLine()
                        Console.Write("Tipo de apartamento: ")
                        tiposApartamento(cantidad) = Console.ReadLine()
                        Console.Write("Fecha de inicio: ")
                        fechasInicio(cantidad) = Console.ReadLine()
                        Console.Write("Fecha de finalizacion: ")
                        fechasFinalizacion(cantidad) = Console.ReadLine()
                        Console.Write("Cantidad de meses: ")
                        meses(cantidad) = Convert.ToInt32(Console.ReadLine())
                        Console.Write("Precio mensual: ")
                        preciosMensuales(cantidad) = Convert.ToDouble(Console.ReadLine())
                        totales(cantidad) = meses(cantidad) * preciosMensuales(cantidad)
                        Console.Write("Estado: ")
                        estados(cantidad) = Console.ReadLine()
                        Console.Write("Observacion: ")
                        observaciones(cantidad) = Console.ReadLine()
                        cantidad += 1
                        Console.WriteLine("Alquiler registrado correctamente.")
                    End If
                '---------------------'
                '--|editar_alquiler|--'
                '---------------------'
                Case 2
                    If cantidad = 0 Then
                        Console.WriteLine("No existen alquileres registrados.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Inquilino: " & inquilinos(i) & " | Apartamento: " & apartamentos(i) & " | Tipo: " & tiposApartamento(i) & " | Inicio: " & fechasInicio(i) & " | Finalizacion: " & fechasFinalizacion(i) & " | Meses: " & meses(i) & " | Precio mensual: " & preciosMensuales(i) & " | Total: " & totales(i) & " | Estado: " & estados(i) & " | Observacion: " & observaciones(i))
                        Next
                        Console.Write("Ingrese el ID del alquiler a editar: ")
                        Dim idEditar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEditar >= 1 And idEditar <= cantidad Then
                            Dim posicion As Integer = idEditar - 1
                            Console.Write("Nuevo inquilino: ")
                            inquilinos(posicion) = Console.ReadLine()
                            Console.Write("Nuevo apartamento: ")
                            apartamentos(posicion) = Console.ReadLine()
                            Console.Write("Nuevo tipo de apartamento: ")
                            tiposApartamento(posicion) = Console.ReadLine()
                            Console.Write("Nueva fecha de inicio: ")
                            fechasInicio(posicion) = Console.ReadLine()
                            Console.Write("Nueva fecha de finalizacion: ")
                            fechasFinalizacion(posicion) = Console.ReadLine()
                            Console.Write("Nueva cantidad de meses: ")
                            meses(posicion) = Convert.ToInt32(Console.ReadLine())
                            Console.Write("Nuevo precio mensual: ")
                            preciosMensuales(posicion) = Convert.ToDouble(Console.ReadLine())
                            totales(posicion) = meses(posicion) * preciosMensuales(posicion)
                            Console.Write("Nuevo estado: ")
                            estados(posicion) = Console.ReadLine()
                            Console.Write("Nueva observacion: ")
                            observaciones(posicion) = Console.ReadLine()
                            Console.WriteLine("Alquiler actualizado correctamente.")
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '-----------------------'
                '--|listar_alquileres|--'
                '-----------------------'
                Case 3
                    If cantidad = 0 Then
                        Console.WriteLine("No existen alquileres registrados.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Inquilino: " & inquilinos(i) & " | Apartamento: " & apartamentos(i) & " | Tipo: " & tiposApartamento(i) & " | Inicio: " & fechasInicio(i) & " | Finalizacion: " & fechasFinalizacion(i) & " | Meses: " & meses(i) & " | Precio mensual: " & preciosMensuales(i) & " | Total: " & totales(i) & " | Estado: " & estados(i) & " | Observacion: " & observaciones(i))
                        Next
                    End If
                '---------------------'
                '--|buscar_alquiler|--'
                '---------------------'
                Case 4
                    If cantidad = 0 Then
                        Console.WriteLine("No existen alquileres registrados.")
                    Else
                        Console.Write("Ingrese el ID del alquiler a buscar: ")
                        Dim idBuscar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idBuscar >= 1 And idBuscar <= cantidad Then
                            Dim posicion As Integer = idBuscar - 1
                            Console.WriteLine("ID: " & ids(posicion) & " | Inquilino: " & inquilinos(posicion) & " | Apartamento: " & apartamentos(posicion) & " | Tipo: " & tiposApartamento(posicion) & " | Inicio: " & fechasInicio(posicion) & " | Finalizacion: " & fechasFinalizacion(posicion) & " | Meses: " & meses(posicion) & " | Precio mensual: " & preciosMensuales(posicion) & " | Total: " & totales(posicion) & " | Estado: " & estados(posicion) & " | Observacion: " & observaciones(posicion))
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '-----------------------'
                '--|eliminar_alquiler|--'
                '-----------------------'
                Case 5
                    If cantidad = 0 Then
                        Console.WriteLine("No existen alquileres registrados.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Inquilino: " & inquilinos(i) & " | Apartamento: " & apartamentos(i) & " | Tipo: " & tiposApartamento(i) & " | Inicio: " & fechasInicio(i) & " | Finalizacion: " & fechasFinalizacion(i) & " | Meses: " & meses(i) & " | Precio mensual: " & preciosMensuales(i) & " | Total: " & totales(i) & " | Estado: " & estados(i) & " | Observacion: " & observaciones(i))
                        Next
                        Console.Write("Ingrese el ID del alquiler a eliminar: ")
                        Dim idEliminar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEliminar >= 1 And idEliminar <= cantidad Then
                            Dim posicion As Integer = idEliminar - 1
                            For i As Integer = posicion To cantidad - 2
                                ids(i) = ids(i + 1)
                                inquilinos(i) = inquilinos(i + 1)
                                apartamentos(i) = apartamentos(i + 1)
                                tiposApartamento(i) = tiposApartamento(i + 1)
                                fechasInicio(i) = fechasInicio(i + 1)
                                fechasFinalizacion(i) = fechasFinalizacion(i + 1)
                                meses(i) = meses(i + 1)
                                preciosMensuales(i) = preciosMensuales(i + 1)
                                totales(i) = totales(i + 1)
                                estados(i) = estados(i + 1)
                                observaciones(i) = observaciones(i + 1)
                            Next
                            cantidad -= 1
                            Console.WriteLine("Alquiler eliminado correctamente.")
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '---------------------'
                '--|mostrar_resumen|--'
                '---------------------'
                Case 6
                    If cantidad = 0 Then
                        Console.WriteLine("No existen alquileres registrados.")
                    Else
                        Dim disponibles As Integer = 0
                        Dim reservados As Integer = 0
                        Dim alquilados As Integer = 0
                        Dim finalizados As Integer = 0
                        Dim cancelados As Integer = 0
                        Dim estudios As Integer = 0
                        Dim unaHabitacion As Integer = 0
                        Dim dosHabitaciones As Integer = 0
                        Dim tresHabitaciones As Integer = 0
                        Dim penthouses As Integer = 0
                        Dim totalMeses As Integer = 0
                        Dim totalIngresos As Double = 0
                        For i As Integer = 0 To cantidad - 1
                            totalMeses += meses(i)
                            totalIngresos += totales(i)
                            If estados(i).ToLower() = "disponible" Then
                                disponibles += 1
                            ElseIf estados(i).ToLower() = "reservado" Then
                                reservados += 1
                            ElseIf estados(i).ToLower() = "alquilado" Then
                                alquilados += 1
                            ElseIf estados(i).ToLower() = "finalizado" Then
                                finalizados += 1
                            ElseIf estados(i).ToLower() = "cancelado" Then
                                cancelados += 1
                            End If
                            If tiposApartamento(i).ToLower() = "estudio" Then
                                estudios += 1
                            ElseIf tiposApartamento(i).ToLower() = "1 habitacion" Then
                                unaHabitacion += 1
                            ElseIf tiposApartamento(i).ToLower() = "2 habitaciones" Then
                                dosHabitaciones += 1
                            ElseIf tiposApartamento(i).ToLower() = "3 habitaciones" Then
                                tresHabitaciones += 1
                            ElseIf tiposApartamento(i).ToLower() = "penthouse" Then
                                penthouses += 1
                            End If
                        Next
                        Console.WriteLine("Alquileres: " & cantidad & " | Disponibles: " & disponibles & " | Reservados: " & reservados & " | Alquilados: " & alquilados & " | Finalizados: " & finalizados & " | Cancelados: " & cancelados & " | Estudios: " & estudios & " | 1 Habitacion: " & unaHabitacion & " | 2 Habitaciones: " & dosHabitaciones & " | 3 Habitaciones: " & tresHabitaciones & " | Penthouses: " & penthouses & " | Total meses: " & totalMeses & " | Total ingresos: " & totalIngresos)
                    End If
                '------------------------------'
                '--|salir_del_menu_principal|--'
                '------------------------------'
                Case 7
                    Console.WriteLine("Gracias por utilizar Alquiler de Apartamentos.")
                Case Else
                    Console.WriteLine("Opcion no valida.")
            End Select
        Loop While opcion <> 7
    End Sub
End Module