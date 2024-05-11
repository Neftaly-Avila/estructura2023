Public Class Main {
    Public Static void main(String[] args) {
        printEvenNumbers(1);
    }

    Public Static void printEvenNumbers(int n) {
        If (n <= 100) {
            If (n % 2 == 0) {
                System.out.println(n);
            }
            printEvenNumbers(n + 1);
        }
    }
}
