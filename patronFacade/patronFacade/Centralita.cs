﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronFacade
{
    //implementa patron facade
    public class Centralita
    {
        private IEmbrague _embrague;
        private IAcelerador _acelerador;
        private IPalancaCambios _palancaCambios;

        public Centralita(IEmbrague embrague, IAcelerador acelerador, IPalancaCambios palancaCambios)
        {
            this._embrague = embrague;
            this._acelerador = acelerador;
            this._palancaCambios = palancaCambios;
        }

        public void AumentarMarcha()
        {
            _acelerador.SoltarAcelerador();
            _embrague.PresionarEmbrague();
            _palancaCambios.PuntoMuerto();
            if (_palancaCambios.GetVelocidadActual() < 5)
                _palancaCambios.InsertarVelocidad(_palancaCambios.GetVelocidadActual() + 1);
            _embrague.SoltarEmbrague();
            _acelerador.PresionarAcelerador();
        }

        public void ReducirMarcha()
        {
            _acelerador.SoltarAcelerador();
            _embrague.PresionarEmbrague();
            _palancaCambios.PuntoMuerto();
            if (_palancaCambios.GetVelocidadActual() > 1)
                _palancaCambios.InsertarVelocidad(_palancaCambios.GetVelocidadActual() - 1);
            _embrague.SoltarEmbrague();
            _acelerador.PresionarAcelerador();
        }
    }
}
