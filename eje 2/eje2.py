# -*- coding: utf-8 -*-
"""
Created on Fri Sep 17 15:24:39 2021

@author: USUARIO
"""
from pyswip import Prolog
prolog = Prolog()

prolog.assertz("padrede('juan','maria')")
prolog.assertz("padrede('pablo','juan')")
prolog.assertz("padrede('pablo','marcela')")
prolog.assertz("padrede('carlos','debora')")
prolog.assertz("(hijode(X, Y) :- padrede(Y,X))")

prolog.assertz ("(abuelode(A,N) :- padrede(A,C),padrede(C,N))")

prolog.assertz ("(hermanode(A,B):-padrede(C,A),padrede(C,B),A \== B)")


prolog.assertz("(familiarde(A,B) :- padrede(A,B))")
prolog.assertz("(familiarde(A,B) :- hijode(A,B))")
prolog.assertz("(familiarde(A,B) :- hermanode(A,B))")



print(bool(list(prolog.query("hijode(juan,pablo)"))))

print(bool(list(prolog.query("abuelode(pablo,maria)"))))

print(bool(list(prolog.query("hermanode(juan,marcela)"))))

print(bool(list(prolog.query("familiarde(debora,carlos)"))))



