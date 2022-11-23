import unittest

from main import Solution


class Tests(unittest.TestCase):
    def test_smallerNumbersThanCurrent_first_case(self):
        nums = [8, 1, 2, 2, 3]
        expected = [4, 0, 1, 1, 3]

        actual = Solution().smallerNumbersThanCurrent(nums)

        self.assertEqual(actual, expected)

    def test_smallerNumbersThanCurrent_second_case(self):
        nums = [6, 5, 4, 8]
        expected = [2, 1, 0, 3]

        actual = Solution().smallerNumbersThanCurrent(nums)

        self.assertEqual(actual, expected)

    def test_smallerNumbersThanCurrent_third_case(self):
        nums = [7, 7, 7, 7]
        expected = [0, 0, 0, 0]

        actual = Solution().smallerNumbersThanCurrent(nums)

        self.assertEqual(actual, expected)
