
# Mobile Bill Counter

This program calculates mobile bill in a given time

## Rules

Take two input DateTime and calculate total bills according to the following rules.

Peak Hour: 9.00 am to 10.59 pm
20 second pulse and each pulse rate 30 paisa

Off-peak Hour: 12.00 am to 8.59 am and 11.00 pm to 11.59 pm
20 second pulse and each pulse rate 20 paisa

Note: If pulse overlap (peak to off-peak or off-peak to peak) then take peak hour rate.


## Sample input

Start time: 2019-08-31 08:59:13 am
End time: 2019-08-31 09:00:39 am

## Breakdown

2019-09-31 08:59:13 + 20 second (2019-09-31 08:59:33) = 20 paisa
2019-09-31 08:59:34 + 20 second (2019-09-31 08:59:54) = 20 paisa
2019-09-31 08:59:55 + 20 second (2019-09-31 09:00:15) = 30 paisa
2019-09-31 09:00:16 + 20 second (2019-09-31 09:00:36) = 30 paisa
2019-09-31 09:00:37+ 3 second (2019-09-31 09:00:39) = 30 paisa

## Sample output

1.3 taka
