﻿namespace _03._Ferrari
{
    public interface ICar
    {
        string Model { get; }

        string DriverName { get; }

        string UseBrakes();

        string PushGasPedal();
    }
}