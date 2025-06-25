doc: Represents a struct or union mission_weighted_category defined within 
  pmdsky-debug.
meta:
  id: mission_weighted_category
  endian: le
  bit-endian: le
  imports: []
seq:
- id: job_board_weight
  type: u2
- id: outlaw_board_weight
  type: u2
- id: cafe_weight
  type: u2
- id: bottle_weight
  type: u2
- id: minimum_rank
  type: u1
- id: min_scenario_balance
  type: u1
- id: secret_rank_needed
  type: u2
- id: number_of_templates
  type: u2
- id: first_template_index
  type: u2
