// See https://aka.ms/new-console-template for more information
using ChainOfResponsibility;

Console.WriteLine("Hello, World!");
/*
 * HttpRequest
 *    
 *    1. Session Ekle
 *    2. UseCORS
 *    3. Authentication
 *    4. Authorization *   
 *    5. Cookies
 */

ValidateReservation validateReservation = new ValidateReservation();
AvailableReservation availableReservation = new AvailableReservation();
Deposit deposit = new Deposit();
validateReservation.Next = availableReservation;
availableReservation.Next = deposit;


Reservation reservation = new Reservation { Info = "Bişeyler" };
validateReservation.Handle(reservation);

