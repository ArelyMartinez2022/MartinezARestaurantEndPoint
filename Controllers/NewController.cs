/*
ARELY MARTINEZ 
OCT 26, 2022 9:30PM
RESTURANT PICKER END POINT 
THIS PROGRAM WILL MAKE IT SO THAT THE USER 
CAN 1 2 OR 3 DEPENDING IF THEY WANT THE PROGRAM 
TO RECOMEND THEM A MEXICAN, CHINESE, OR ITALIAN 
RESTURANT. AND ON POSTMAN IT WILL REPSOND WITH 
WHAT THEY CHOOSE AND THE RECOMENDED RESTURANT.
PEER REVIEW: ISAIAH FEGUSON -- CODE WORKS GREAT, 
I LIKE THE USE OF IF STATEMENTS I USED SWITCHED 
STATEMENTS AND I THINK THIS CODE IS SUPER 
INTERESTING! GREAT JOB~! 
*/

using Microsoft.AspNetCore.Mvc;

namespace day2ApiInput.Controllers;

[ApiController]
[Route("[controller]")]
public class NewController : ControllerBase
{

    [HttpGet]
    [Route("RES")]
    public string NewDefault()
    {
        return $"LETS PICK A RESTUARNT FOR YOUl! \nWHAT DO YOU FEEL LIKE HAVING? \nENTER '1' FOR MEXICAN \nENTER '2' FOR CHINESE \nENTER '3' FOR ITALIAN";
    }

    [HttpGet]
    [Route("RES/{number1}")]
    public string Math(int number1)
    {
        //int convertNum1 = Convert.ToInt32(number1);
        string answer = "";
        string cat = "";

        if (number1 == 1)
        {
            string[] Mex = { "LA COSTA", "LA ESTRELLA", "TAQUERIA LA MEXICANA", "EL TORITO", "TACOS LA POTRANCA", "TAQUERIA LAS COMADRES", "LA DONA", "MARISCOS LA COSTA", "RUBIO'S COSTAL GRILL", "LOS PRIMOS TEX MEX FOOD" };
            cat = "YOU CHOSE MEXICAN WHY DONT YOU TRY - ";
            Random random = new Random();
            int randomOut = random.Next(0, 10);
            answer = Mex[randomOut];
        }
        if (number1 == 2)
        {
            string[] Chi = { "PANDA EXPRESS", "AMAZING KITCHEN", "CHINA WORK", "NEW KING BUFFET", "FORTUNE GARDEN CHINESE", "MEI MEI CHINESE FOOD", "GOLDEN EAGLE RESTAURANT", "GOLDEN BOWL RESTAURANT", "MIDORI FINE ASAIN CUISINE", "NEW CHINA RESTAURANT" };
            cat = "YOU CHOSE CHINESE WHY DONT YOU TRY - ";
            Random random = new Random();
            int randomOut = random.Next(0, 10);
            answer = Chi[randomOut];
        }
        if (number1 == 3)
        {
            string[] Italin = { "OLIVE GARDEN", "ROMANO'S MACARONI GRILL", "LOCANDO WINE BAR", "RUSTY'S", "BLAZE PIZZA", "PADELLA ITALIANA", "M & J BRISTO", "CHIANTI'S", "MOD PIZZA", "LOCANDO RAVELLO" };
            cat = "YOU CHOSE ITALIN WHY DONT YOU TRY - ";
            Random random = new Random();
            int randomOut = random.Next(0, 10);
            answer = Italin[randomOut];
        }
        return $"{cat} {answer}";
    }

    //return$"This would be my return {var} "
}